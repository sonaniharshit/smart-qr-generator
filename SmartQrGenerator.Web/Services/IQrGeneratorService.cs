namespace SmartQrGenerator.Web.Services
{
    public interface IQrGeneratorService
    {
        string GenerateQrCode(string url);
    }
}
