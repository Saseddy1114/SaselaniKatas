using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCopier
{
    public interface ISource
    {
        char ReadChar();
        int ReadChars(char[] chars, int index, int count); 
    }
}
