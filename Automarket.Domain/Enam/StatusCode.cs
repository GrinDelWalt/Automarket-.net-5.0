namespace Automarket.Domain.Enam
{
	public enum StatusCode
	{
		OK = 200,
		InternalServerError =500,
		ObjectNotFound = 10,

        UserNotFound = 0,
        UserAlreadyExists = 1,
    }
}
