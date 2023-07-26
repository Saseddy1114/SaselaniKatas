using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCopier
{
    public class Copier
    {
        private readonly ISource _source;
        private readonly IDestination _destination;

        public Copier(ISource source, IDestination destination)
        {
            _source = source;
            _destination = destination;
        }

        public void Copy()
        {
            char c;

            while (( c = _source.ReadChar()) != '\n')
            {
                _destination.WriteChar(c);
            }
        }

    }
}
