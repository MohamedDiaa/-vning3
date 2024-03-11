using System;
namespace Polymorfism
{
	public class NumericInputError: UserError
	{
		public NumericInputError()
		{
		}

        public override string UEMessage()
        {
            return "You tried to use a nnumeric input in a text only field. This fired an error!";
        }
    }
}

