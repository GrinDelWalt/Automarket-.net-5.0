using Automarket.Domain.Enam;
using Automarket.Domain.Interfeces;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;

namespace Automarket.Domain.Response
{
	public class BaseResponse<T> : IBaseResponse<T>
	{
		public string Description { get; set; }//запись ошибок работы с бд
		public StatusCode StatusCode { get; set; }
		public T Data { get; set; }
	}
}
