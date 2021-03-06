namespace token.Application.Contracts.AppService;

/// <summary>
/// Pdf service
/// </summary>
public interface IPdfService
{
    /// <summary>
    /// 合并pdf文件
    /// </summary>
    /// <param name="streams"></param>
    /// <returns></returns>
    Task<byte[]> MangePdfAsync(List<Stream> streams);
    
    /// <summary>
    /// 图片转换pdf
    /// </summary>
    /// <param name="streams"></param>
    /// <returns></returns>
    Task<byte[]> ImgToPdfAsync(List<Stream> streams);
    
    /// <summary>
    /// pdf转图片
    /// </summary>
    /// <param name="streams"></param>
    /// <returns></returns>
    Task<byte[]> PdfToImgAsync(List<Stream> streams);

    /// <summary>
    /// Word转pdf
    /// </summary>
    /// <param name="streams"></param>
    /// <returns></returns>
    Task<byte[]> PdfToWordAsync(List<Stream> streams);
}
