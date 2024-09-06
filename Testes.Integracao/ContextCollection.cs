using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.Integracao;

[CollectionDefinition(nameof(ContextCollection))]
public class ContextCollection : ICollectionFixture<ContextFixture>
{
}
