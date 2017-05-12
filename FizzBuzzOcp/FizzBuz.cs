using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzOcp
{

	public interface  IFizzBuzzRule
	{
		string convert(int i);
	}

	public class EchoRule : IFizzBuzzRule	
	{
		public string convert(int i)
		{
			return i.ToString();
		}
	}

	public class FizzBuz
	{
		private List<IFizzBuzzRule> _rules;
		
		public FizzBuz()
		{
			_rules = new List<IFizzBuzzRule>();
			_rules.Add(new ModuloRule(5, "Buzz"));
			_rules.Add(new ModuloRule(3, "Fizz"));	
		}

		public string say(int i)
		{
			var aggregate = _rules.Aggregate(
				"",
				(a,r) => a + r.convert(i));
			
			return aggregate != "" ? aggregate : new EchoRule().convert(i);
		}
	}

	public class ModuloRule : IFizzBuzzRule
	{
		private readonly string _convert;
		private readonly int _modulo;

		public ModuloRule(int modulo, string convert)
		{
			_modulo = modulo;
			_convert = convert;
		}

		public string convert(int i)
		{
			return i % _modulo == 0 ? _convert : "";
		}
	}
}