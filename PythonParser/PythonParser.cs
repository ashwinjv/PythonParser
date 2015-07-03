using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythonParser
{
    public class PythonParser
    {
        public void Parse(string input)
        {
            
            AntlrInputStream stream = new AntlrInputStream(input);
            ITokenSource lexer = new Python3Lexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            Python3Parser parser = new Python3Parser(tokens);
            parser.BuildParseTree = true;
            KeyPrinter printer = new KeyPrinter();
            IParseTree tree = parser.file_input();
            //ParseTreeWalker.Default.Walk(printer, tree);
            //IParseTree tree = parser.StartRule(); 
        }
    }
}
