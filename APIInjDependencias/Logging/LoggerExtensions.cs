using APIInjDependencias.Models;

namespace APIInjDependencias.Logging;

public static class LoggerExtensions
{
    public static void LogDI<T>(this ILogger<T> logger, ValoresInjecaoUsandoKey valores) =>
        logger.LogInformation($"Key: {valores.Key} -- Construtor: {valores.Construtor} -- " +
            $"Action: {valores.Action}");
}
