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

        public void Copy(int? numberOfCharacters = null)
        {
            char c;
            if (numberOfCharacters != null)
            {
                int index = _source.ReadChars(numberOfCharacters.GetValueOrDefault(0)).ToList().IndexOf('\n');
                index = index == -1 ? numberOfCharacters.GetValueOrDefault(0) : index;
                _destination.WriteChars(_source.ReadChars(index - 1));
             }
            else
            { 
                while ((c = _source.ReadChar()) != '\n')
                {
                    _destination.WriteChar(c);  
                }
            }
        }

    }
}
