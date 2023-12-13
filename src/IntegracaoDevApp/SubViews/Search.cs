using Dataplace.Core.Domain.Localization.Messages.Extensions;
using dpLibrary05.Infrastructure.Helpers;
using dpLibrary05.SymphonyInterface;

namespace Dataplace.IntegracaoTechDev.Presentation.Commom.Search
{
    internal class IntegracaoTechDevSearch : clsSymSearch
    {
        public static ISymInterfaceSearch Find_Marca(SearchArgs args = default(SearchArgs))
        {
            ISymInterfaceSearch se = DefaultInstance();
            se.Title = 7571.ToMessage();

            se.SecurityID = 88;
            se.Id = nameof(Find_Marca);
            se.SetaAzul = true;

            se.Source = "SELECT marca, descricao FROM Marca";

            se.MethodSort = "marca";

            //Código
            se.Fields.Add(new clsSymInterfaceSearchField() { SearchIndex = 0, Name = "Código", Width = 80, IsReturnValue = true });

            //Descrição
            se.Fields.Add(new clsSymInterfaceSearchField() { SearchIndex = 1, Name = "Descrição", Width = 300 });

            SetParameters(ref se, args);
            return se;
        }
    }
}
