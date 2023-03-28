using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using ThoughtWorks.QRCode.Codec;
using System.Drawing;
using ThoughtWorks.QRCode.Codec.Data;

namespace MyADBTools
{
    public class QRCodeUtil
    {
        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="barcodeText">文本</param>
        /// <returns>图片</returns>
        public Bitmap BarcodeImage(String barcodeText)
        {

            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();

            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;//编码方式(注意：BYTE能支持中文，ALPHA_NUMERIC扫描出来的都是数字)
            qrCodeEncoder.QRCodeScale = 5;//大小(值越大生成的二维码图片像素越高)
            qrCodeEncoder.QRCodeVersion = 0;//版本(注意：设置为0主要是防止编码的字符串太长时发生错误)
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;//错误效验、错误更正(有4个等级)
            qrCodeEncoder.QRCodeBackgroundColor = Color.White;
            qrCodeEncoder.QRCodeForegroundColor = Color.Black;

            Bitmap img = qrCodeEncoder.Encode(barcodeText, Encoding.UTF8);//指定utf-8编码， 支持中文
            return img;

            //string httpFileName = System.Environment.CurrentDirectory;
            //string fileName = "/a.jpg";
            //img.Save(httpFileName + fileName);//保存位图 
        }

        /// <summary>
        /// 解析二维码文本
        /// </summary>
        /// <param name="bitmap">图片对象</param>
        /// <returns></returns>
        public string QRCodeDecoderUtil(Bitmap bitmap)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            string decodedString = "";
            try
            {
                decodedString = decoder.decode(new QRCodeBitmapImage(bitmap), Encoding.UTF8);//指定utf-8编码， 支持中文  
            }
            catch (Exception e)
            {
                return "请先生成二维码！";
            }
            return decodedString;
        }

    }
}
