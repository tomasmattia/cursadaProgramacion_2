using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IInterface
    {
        bool SerializarXml(string path);

        bool DeserializarXml(string path);

        bool SerializarBinario(string path);

        bool DeserializarBinario(string path);
    }
}
