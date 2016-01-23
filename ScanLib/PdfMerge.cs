using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ScanLib.PdfMerge
{
    public class PdfMerge
    {
        public static void MergeFiles(string destinationFile, string[] sourceFiles)
        {
            try
            {
                int f = 0;
                // we create a reader for a certain document			
                PdfReader reader = new PdfReader(sourceFiles[f]);
                // we retrieve the total number of pages			
                int n = reader.NumberOfPages;
                //Console.WriteLine("There are " + n + " pages in the original file.");			
                // step 1: creation of a document-object			

                Document document = new Document(reader.GetPageSizeWithRotation(1));
                // step 2: we create a writer that listens to the document			
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(destinationFile, FileMode.Create));
                // step 3: we open the document			
                document.Open();

                PdfContentByte cb = writer.DirectContent;
                PdfImportedPage page;
                int rotation;
                // step 4: we add content			
                while (f < sourceFiles.Length)
                {
                    int i = 0;
                    while (i < n)
                    {
                        i++;
                        document.SetPageSize(reader.GetPageSizeWithRotation(i));
                        document.NewPage();
                        page = writer.GetImportedPage(reader, i);
                        rotation = reader.GetPageRotation(i);
                        if (rotation == 90 || rotation == 270)
                        {
                            cb.AddTemplate(page, 0, -1f, 1f, 0, 0, reader.GetPageSizeWithRotation(i).Height);
                        }
                        else
                        {
                            cb.AddTemplate(page, 1f, 0, 0, 1f, 0, 0);
                        }
                        //Console.WriteLine("Processed page " + i);				
                    }
                    f++;
                    if (f < sourceFiles.Length)
                    {
                        reader = new PdfReader(sourceFiles[f]);
                        // we retrieve the total number of pages					
                        n = reader.NumberOfPages;
                        //Console.WriteLine("There are " + n + " pages in the original file.");				
                    }
                }			// step 5: we close the document			
                document.Close();
            }
            catch (Exception e)
            {
                string strOb = e.Message;
            }
        }

        public int CountPageNo(string strFileName)
        {			// we create a reader for a certain document		
            PdfReader reader = new PdfReader(strFileName);
            // we retrieve the total number of pages		
            return reader.NumberOfPages;
        }

        public static void CreateTmpPDFFile(string tmpPDFFile, string jpgFile)
        {
            Document doc = new Document(iTextSharp.text.PageSize.A4, 0, 0, 0, 0);
            try
            {
                string pdfFilePath = tmpPDFFile;
                //Create Document class object and set its size to letter and give space left, right, Top, Bottom Margin
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(pdfFilePath, FileMode.Create));
                doc.Open();//Open Document to write

                ////Write some content into pdf file
                //Paragraph paragraph = new Paragraph("This is my first line using Paragraph.");

                // Now image in the pdf file
                string imageFilePath = jpgFile;
                iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageFilePath);

                //Resize image depend upon your need                
                //jpg.ScalePercent(20);
                jpg.ScaleToFit(600f, 950f);
                
                //Give space before image
                //jpg.SpacingBefore = 30f;

                //Give some space after the image
                //jpg.SpacingAfter = 1f;
                jpg.Alignment = Element.ALIGN_CENTER;

                //doc.Add(paragraph); // add paragraph to the document

                doc.Add(jpg); //add an image to the created pdf document
                doc.Close();
            }
            catch (DocumentException docEx)
            {
                //handle pdf document exception if any
            }
            catch (IOException ioEx)
            {
                // handle IO exception
            }
            catch (Exception ex)
            {
                // ahndle other exception if occurs
            }
            finally
            {
                //Close document and writer
                doc.Close();

            }
        }
    }
}