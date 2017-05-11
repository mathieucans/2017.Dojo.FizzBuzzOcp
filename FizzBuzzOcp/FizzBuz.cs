﻿using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzOcp
{

	public interface  IFizzBuzzRule
	{
		bool match(int i);
		string convert(int i);
	}

	public class EchoRule : IFizzBuzzRule	
	{
		public bool match(int i)
		{
			return true;
		}

		public string convert(int i)
		{
			return i.ToString();
		}
	}

	public class FizzRule : IFizzBuzzRule
	{
		public bool match(int i)
		{
			return (i%3) == 0;
		}

		public string convert(int i)
		{
			return "Fizz";
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
			_rules.Add(new EchoRule());
		}

		public string say(int i)
		{
			return _rules.First(r => r.match(i)).convert(i);
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

		public bool match(int i)
		{
			return i%_modulo == 0;
		}

		public string convert(int i)
		{
			return _convert;
		}
	}
}