namespace JobSearchingAI.Infraestructure.Exceptions;

public class InvalidHttpRequestException(string message) : Exception(message)
{
}