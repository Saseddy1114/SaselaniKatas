using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCopier
{
    public interface IDestination
    {
        void WriteChar(char c);
        void WriteChars(char[] chars, int index, int count);
    }
}
