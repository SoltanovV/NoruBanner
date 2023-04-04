namespace backend.Interfaces;

public interface IAnalisisBanner
{
    /// <summary>
    /// Сервис для получение информации о пользователе
    /// </summary>
    /// <param name="analys">Информация с клиента</param>
    /// <returns></returns>
    public Task ReceivingInformation(Analys analys);
}