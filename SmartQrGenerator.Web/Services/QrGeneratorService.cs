using QRCoder;

namespace SmartQrGenerator.Web.Services
{
    public class QrGeneratorService : IQrGeneratorService
    {
        public string GenerateQrCode(string url)
        {
            using var generator = new QRCodeGenerator();
            using var data = generator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);

            var qr = new PngByteQRCode(data);

            return Convert.ToBase64String(qr.GetGraphic(20));
        }
    }
}
