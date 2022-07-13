// Create an instance of the API
using BarcodeLib;
using System.Drawing;
using System.Drawing.Imaging;

Barcode barcodeAPI = new Barcode();

// Define basic settings of the image
int imageWidth = 290;
int imageHeight = 120;
Color foreColor = Color.Black;
Color backColor = Color.Transparent;
string data = "978020137962";

// Generate the barcode with your settings
Image barcodeImage = barcodeAPI.Encode(TYPE.EAN13, data, foreColor, backColor, imageWidth, imageHeight);

// Store image in some path with the desired format
barcodeImage.Save(@"D:\USERDATA\Desktop/barcode.png", ImageFormat.Png);
