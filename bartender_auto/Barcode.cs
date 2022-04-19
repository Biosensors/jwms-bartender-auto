using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartenderStudy
{
    internal class Barcode //extends Code
    {
        public class Scanning
        {
            public String fullScanCode = "";
            //        String LAST_UPDATE="";
            public String EAN = "";
            public String BATCH = "";
            public String BATCH_SLED = "";
            public String serialNo = "";
            public Boolean valid = false;
            public String errMsg = "";
            public String MATERIAL = "";
            //        String EAN_CONVERSION="";

            public String prop = "";
            public String tmp_fullScanCode = "";   //"MATERIAL"   ;serialNo
        }

        public Scanning getScanningObj()
        {
            return new Scanning();
        }

        public String checkInfoComplete(Scanning scanning)
        {
            String msg = "";
            if (scanning.EAN == "" && scanning.MATERIAL == "")
            {
                scanning.valid = false;
                msg = msg + "EAN Code is required";
            }
            if (scanning.BATCH_SLED == "")
            {
                scanning.valid = false;
                msg = msg + "BATCH_SLED is required";
            }
            if (scanning.BATCH == "")
            {
                scanning.valid = false;
                msg = msg + "Batch No is required";
            }

            return msg;
        }


        public void parseBarcode(Scanning self)
        {
            if (self.fullScanCode == "")
            {
                return;
            }
            if (self.fullScanCode != "" && self.fullScanCode.Length > 60)
            {
                self.valid = false;
                return;
            }

            char ascii124 = '|';       //for text testing purpose
            char ascii29 = (char)29;       //GS (group separator)
            if (!self.valid)
            {
                return;
            }

            if (self.tmp_fullScanCode.Length < 3)
            {
                self.valid = false;
                return;
            }
            String marker = self.tmp_fullScanCode.Substring(0, 2);
            if (marker == "01" || marker == "02")
            { //EAN code
                if (self.tmp_fullScanCode.Length >= 16)
                {
                    self.EAN = self.tmp_fullScanCode.Substring(2, 16 - 2); //ignore the second occurrence
                    if (self.tmp_fullScanCode.Length > 16)
                    {
                        self.tmp_fullScanCode = self.tmp_fullScanCode.Substring(16);
                        parseBarcode(self);
                    }
                    else
                    {
                        self.valid = true;
                        return;
                    }
                }
                else
                {
                    self.valid = false;
                    return;
                }
            }
            else if (marker == "17")
            { //BATCH_SLED
                if (self.tmp_fullScanCode.Length >= 6)
                {
                    self.BATCH_SLED = self.tmp_fullScanCode.Substring(2, 8 - 2);//ignore the second occurrence
                    if (self.tmp_fullScanCode.Length > 8)
                    {
                        self.tmp_fullScanCode = self.tmp_fullScanCode.Substring(8);
                        parseBarcode(self);
                    }
                    else
                    {
                        self.valid = true;
                        return;
                    }
                }
                else
                {
                    self.valid = false;
                    return;
                }
            }
            else if (marker == "37")
            { //BATCH_SLED
                if (self.tmp_fullScanCode.Length > 3)
                {
                    self.tmp_fullScanCode = self.tmp_fullScanCode.Substring(3);
                    parseBarcode(self);
                    //                return parser(self.tmp_fullScanCode.substring(3));
                }
                else
                {
                    self.valid = true;
                    return;
                }
            }
            else if (marker == "0Z" || marker == "10" || marker == "21" || marker == "30" || marker == "37")
            {
                String prop;

                switch (marker)
                {
                    case "0Z":
                        prop = "MATERIAL";
                        break;
                    case "10":
                        prop = "BATCH";
                        break;
                    case "21":
                        prop = "serialNo";
                        break;
                    default:
                        prop = "info" + marker;
                        break;
                }


                //try to find ascii29
                int stopPosition = self.tmp_fullScanCode.Length - 2;
                for (int i = 0; i < self.tmp_fullScanCode.Length; i++)
                {
                    if (self.tmp_fullScanCode[i] == ascii29 || self.tmp_fullScanCode[i] == ascii124)
                    {
                        stopPosition = i;
                        break;
                    }
                }
                //            self[prop]=code.substring(2,stopPosition);//ignore the second occurrence
                self.prop = prop;
                switch (prop)
                {
                    case "MATERIAL":

                        self.MATERIAL = self.tmp_fullScanCode.Substring(2, stopPosition);
                        break;
                    case "BATCH":
                        if (self.tmp_fullScanCode.IndexOf("|") == -1)
                        {
                            self.BATCH = self.tmp_fullScanCode.Substring(2, stopPosition);
                        }
                        else
                        {
                            self.BATCH = self.tmp_fullScanCode.Substring(2, stopPosition - 2);
                            self.tmp_fullScanCode = self.tmp_fullScanCode.Replace("|", "");
                        }
                        break;
                    case "serialNo":
                        self.serialNo = self.tmp_fullScanCode.Substring(2, stopPosition);
                        break;
                }



                if (self.tmp_fullScanCode.Length > stopPosition + 2)
                {
                    self.tmp_fullScanCode = self.tmp_fullScanCode.Substring(stopPosition);
                    parseBarcode(self);
                }
                else
                {
                    self.valid = true;
                    return;
                }

            }
            else
            {
                self.valid = false;
                return;
            }
            checkInfoComplete(self);
        }


        public String replaceGSseparator(String barcode)
        {
            char ascii124 = '|';       //for text testing purpose
            char ascii29 = (char)29;       //GS (group separator)
            return barcode.Replace(ascii29, ascii124);
        }
    }
}


