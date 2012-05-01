using System;
using System.Drawing;
using System.Drawing.Drawing2D;

public class Watermark
{
    //this fuction takes an Image and String for watermarking as argument    
    //and returns an Image with watermark    

    public static Bitmap WaterMarkToImage(string ImagePath, string watermark)
    {
        Bitmap bmp;
        bmp = new Bitmap(ImagePath);
        Graphics graphicsObject;
        int x, y;
        try
        {
            //create graphics object from bitmap            
            graphicsObject = Graphics.FromImage(bmp);
        }
        catch (Exception e)
        {
            Bitmap bmpNew = new Bitmap(bmp.Width, bmp.Height);
            graphicsObject = Graphics.FromImage(bmpNew);
            graphicsObject.DrawImage(bmp, new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel);
            bmp = bmpNew;
        }
        int startsize = (bmp.Width / watermark.Length);
        //get the font size with respect to length of the string     
        //x and y cordinates to draw a string      
        x = 0;
        y = bmp.Height / 2;
        //System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat(StringFormatFlags.DirectionVertical); -> draws a vertical string for watermark        
        System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat(StringFormatFlags.NoWrap);
        //drawing string on Image        
        graphicsObject.DrawString(watermark, new Font("Verdana", startsize, FontStyle.Bold), new SolidBrush(Color.FromArgb(60, 255, 255, 255)), x, y, drawFormat);
        //return a water marked image
        return (bmp);
    }


    static void Main(string[] args)
    {
        System.Drawing.Bitmap bmp = Watermark.WaterMarkToImage("c:/test2.jpg", "This is a test");
        bmp.Save("c:/Users/Ken/Documents/output.jpg");
    }
}
