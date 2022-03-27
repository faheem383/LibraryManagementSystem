using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Members.BooksFeatures.Commands
{
	public interface ILoandBookFeaturesCommand
	{
		void AddNewLoandBook(Domain.Members.Books.LoandBook book);

		void UpdateLondBook(int id, Domain.Members.Books.LoandBook book);
	}
}
