using System.ComponentModel.DataAnnotations;

namespace backend.Models.Entity;

/// <summary>
/// Анализ 
/// </summary>
public class Analys
{
    /// <summary>
    /// Id 
    /// </summary>
    public int Id { get; set; }
    
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
    public required UserAction Action { get; set; } = UserAction.Saw;
    
}

/// <summary>
/// Действие пользователя
/// </summary>
public enum UserAction
{
    /// <summary>
    /// Увидел баннер
    /// </summary>
    Saw, 
    /// <summary>
    /// Нажал на баннер
    /// </summary>
    Click
}