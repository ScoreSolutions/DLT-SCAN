using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
//using OCRTools;

namespace ScanLib.OCRToolsBarcode
{
    //ใช้ Reference ของ OCRTools.dll ด้วยนะ
    
    public class OCRToolsBarcode
    {
        

        string _err = "";

        public  string ErrorMessage {
            get { return _err; }
        }

        public string OCRProcess(string fileName) {
            OCRTools.OCR ocr = new OCRTools.OCR();

            string ret = "";
            ListView lst = new ListView();

            ocr.ProductName = "StandardBar";
            ocr.CustomerName = "Version5";
            ocr.OrderID = "5142";
            ocr.RegistrationCodes = "7337-3411-0444-3204";
            ocr.ActivationKey = "1221-8631-8084-3595";

            ocr.OCRType = OCRTools.OCRType.Barcode;
            ocr.BitmapImageFile = fileName;
            ocr.Process();

            //ocr.SetListViewBarcode(lst);
            //for (int i = 0; i < lst.Items.Count; i++)
            //{
            //    ret = lst.Items[i].SubItems[2].Text;
            //}
            _err = ocr.TextResultsStatusMessage;
            ret = ocr.Text.Replace("*","");
            return ret;
        }


        public string OCRZoneProcess(string filename) {
            string ret = "";
            OCRTools.OCR ocr = new OCRTools.OCR();

            try
            {
                ocr.ProductName = "StandardBar";
                ocr.CustomerName = "Version5";
                ocr.OrderID = "5142";
                ocr.RegistrationCodes = "7337-3411-0444-3204";
                ocr.ActivationKey = "1221-8631-8084-3595";

                ocr.OCRType = OCRTools.OCRType.Barcode;
                ocr.BitmapImageFile = filename;

                int PointX = 728;
                int PointY = 1116;
                int bHeight = 250;
                int bWidth = 900;
                bool lResult = ocr.SetRegion(PointX, PointY, bWidth, bHeight);
                if (lResult == false)
                {
                    _err = "Error: Nothing selected. Enter Zone Coordinates, or lasso barcode with your mouse to assign coordinates";
                    return "";
                }

                ocr.Process();
                ret = ocr.Text.Replace("*", "");
            }
            catch (Exception e) {
                _err = ocr.TextResultsStatusMessage;
                ret = "";
            }

            return ret;
        }

        public string OCRProcessBitmap(Bitmap bim)
        {
            OCRTools.OCR ocr = new OCRTools.OCR();
            string ret = "";
            ListView lst = new ListView();

            ocr.ProductName = "StandardBar";
            ocr.CustomerName = "Version5";
            ocr.OrderID = "5142";
            ocr.RegistrationCodes = "7337-3411-0444-3204";
            ocr.ActivationKey = "1221-8631-8084-3595";

            ocr.OCRType = OCRTools.OCRType.Barcode;
            ocr.BitmapImage = bim;
            ocr.Process();

            //ocr.SetListViewBarcode(lst);
            //for (int i = 0; i < lst.Items.Count; i++)
            //{
            //    ret = lst.Items[i].SubItems[2].Text;
            //}
            //_err = ocr.TextResultsStatusMessage;
            ret = ocr.Text.Replace("*", "");
            return ret;
        }
    }
}
