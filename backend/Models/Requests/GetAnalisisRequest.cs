namespace backend.Models.Requests;

/// <summary>
/// Получение данные с запроса
/// </summary>
public class GetAnalisisRequest
{
    /// <summary>
    /// Токен пользователя
    /// </summary>
    public required  string UserIp { get; set; }
    
    /// <summary>
    /// Название банера
    /// </summary>
    public required string NameBanner { get; set; }
    
    /// <summary>
    /// Ссылка на сайт
    /// </summary>
    public required string UrlWebsite { get; set; }
    
    /// <summary>
    /// Время перехода
    /// </summary>
    public required string Date { get; set; }

    /// <summary>
    /// Действие пользователя
    /// </summary>
    public required UserAction Action { get; set; }
}
