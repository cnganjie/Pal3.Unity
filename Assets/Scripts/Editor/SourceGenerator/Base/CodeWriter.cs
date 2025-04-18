// ---------------------------------------------------------------------------------------------
//  Copyright (c) 2021-2025, Jiaqi (0x7c13) Liu. All rights reserved.
//  See LICENSE file in the project root for license information.
// ---------------------------------------------------------------------------------------------

namespace Editor.SourceGenerator.Base
{
    using System.Linq;
    using System.Text;

    public struct CodeWriter
    {
        public StringBuilder Buffer;
        public int SpacesPerIndentLevel;

        private int _indentLevel;

        public void BeginBlock()
        {
            WriteIndentInternal();
            Buffer.Append("{\n");
            _indentLevel++;
        }

        public void EndBlock(bool withSemicolon = false)
        {
            _indentLevel--;
            WriteIndentInternal();
            Buffer.Append(withSemicolon ? "};\n" : "}\n");
        }

        public void WriteLine()
        {
            Buffer.Append('\n');
        }

        public void WriteLine(string text)
        {
            if (!text.All(char.IsWhiteSpace))
            {
                WriteIndentInternal();
                Buffer.Append(text);
            }

            Buffer.Append('\n');
        }

        public void Write(string text)
        {
            Buffer.Append(text);
        }

        private void WriteIndentInternal()
        {
            for (int i = 0; i < _indentLevel; i++)
            {
                for (int j = 0; j < SpacesPerIndentLevel; j++)
                {
                    Buffer.Append(' ');
                }
            }
        }

        public void WriteIndent()
        {
           for (int i = 0; i < SpacesPerIndentLevel; i++) Buffer.Append(' ');
        }
    }
}