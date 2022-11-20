namespace Automarket.Domain.Interfeces
{
	public interface IBaseResponse<T>
	{
		T Data { get; }
	}
}
