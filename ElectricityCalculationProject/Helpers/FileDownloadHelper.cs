namespace ElectricityCalculationProject.Helpers
{
    public static class FileDownloadHelper
    {
        public static async Task<byte[]> DownloadFile(string url)
        {
            var content = await GetUrlContent(url);
            if (content != null)
            {
                return content;
            }

            // For future implementations
            return content;
        }

        public static async Task<byte[]?> GetUrlContent(string url)
        {
            using (var client = new HttpClient())
            {
                using (var file = await client.GetStreamAsync(url).ConfigureAwait(false))
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await file.CopyToAsync(memoryStream);
                        return memoryStream.ToArray();
                    }
                }
            }
        }

    }
}
