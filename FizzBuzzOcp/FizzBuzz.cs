﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzOcp
{
    public class FizzBuzz
	{
		private List<IFizzBuzzRule> _rules;
		
		public FizzBuzz()
		{
			_rules = new List<IFizzBuzzRule>();
			_rules.Add(new ConcatRule(new [] { new ModuloRule(3, "Fizz"), new ModuloRule(5, "Buzz")}));
			_rules.Add(new ModuloRule(5, "Buzz"));
			_rules.Add(new ModuloRule(3, "Fizz"));	
			_rules.Add(new EchoRule());	
		}

		public string say(int i)
		{
		    return _rules.First(r => r.match(i)).convert(i);			
		}
	}
}