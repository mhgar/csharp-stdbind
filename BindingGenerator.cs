using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
	
public class Program
{		
	static readonly string[] TemplateArgs = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P" };
	const int MaxArgs = 16;
	public static string JoinedTemplateArgs(int start, int count) { return String.Join(", ", TemplateArgs.ToList().GetRange(start, count)); }
	public readonly static string[] BindingParams = TemplateArgs.AsEnumerable().Select(arg => arg.ToLower()).ToArray();
	public static string JoinedBindingParams(int start, int count) { return String.Join(", ", Enumerable.Range(start, count).Select(i => TemplateArgs[i] + " " + BindingParams[i])); }
	public static string JoinedTypelessBindingParams(int start, int count) { return String.Join(", ", BindingParams.ToList().GetRange(start, count)); }
	
	public static void Main()
	{		
		// This produces output correctly but it looks horrible. Please do not read it.
		// It also dumps everything in stdout but it should probably do it into a file.
	
		var output = new StringBuilder();
		
		Console.WriteLine("namespace Wander.Functional {");
		Console.WriteLine("public static class Binding {");
    
		// Generate actions
		foreach (var totalArgs in Enumerable.Range(0, MaxArgs + 1)) {
			foreach (var splitPos in Enumerable.Range(0, totalArgs + 1)) {
				int lastParma = totalArgs - splitPos;
				Console.WriteLine("/// Get a reference to a function that takes {0} argument(s), filling out {1}.", totalArgs, splitPos);
			
				output.Append("public static Action");
				if (splitPos != totalArgs) {
					output.Append("<");
					output.Append(JoinedTemplateArgs(splitPos, lastParma));
					output.Append(">");
				}
				
				output.Append(" BindAction");			
				if (totalArgs != 0) {
					output.Append("<");
					output.Append(JoinedTemplateArgs(0, totalArgs));
					output.Append(">");
				}
				
				output.Append("(Action");
				if (totalArgs != 0) {
					output.Append("<");
					output.Append(JoinedTemplateArgs(0, totalArgs));
					output.Append(">");
				}
				
				output.Append(" function");
				if (splitPos != 0) {
					output.Append(", ");
					output.Append(JoinedBindingParams(0, splitPos));
				}
				
				output.AppendLine(") {");
				
				output.Append("return (");
				if (totalArgs != 0) {
					output.Append(JoinedBindingParams(splitPos, lastParma));
				}
				
				output.Append(") => ");
				output.Append("function(");
				if (totalArgs != 0) {
					output.Append(JoinedTypelessBindingParams(0, totalArgs));
				}
				output.AppendLine(");");
				output.AppendLine("}");
				
				Console.WriteLine(output.ToString());
				output.Clear();
			}	 	
		}
		
		// Generate functions
		foreach (var totalArgs in Enumerable.Range(0, MaxArgs + 1)) {
			foreach (var splitPos in Enumerable.Range(0, totalArgs + 1)) {
				int lastParma = totalArgs - splitPos;
				Console.WriteLine("/// Get a reference to a function that takes {0} argument(s), filling out {1}.", totalArgs, splitPos);
				output.Append("public static Func<");
				if (splitPos != totalArgs) {
					output.Append(JoinedTemplateArgs(splitPos, lastParma));
					output.Append(", ");
				}
				output.Append("RETURN>");
				
				output.Append(" BindFunc<");			
				if (totalArgs != 0) {
					output.Append(JoinedTemplateArgs(0, totalArgs));
					output.Append(", ");
				}
				output.Append("RETURN>");
				
				output.Append("(Func<");
				if (totalArgs != 0) {
					output.Append(JoinedTemplateArgs(0, totalArgs));
					output.Append(", ");
				}
				output.Append("RETURN>");
				
				output.Append(" function");
				if (splitPos != 0) {
					output.Append(", ");
					output.Append(JoinedBindingParams(0, splitPos));
				}
				
				output.AppendLine(") {");
				
				output.Append("return (");
				if (totalArgs != 0) {
					output.Append(JoinedBindingParams(splitPos, lastParma));
				}
				
				output.Append(") => ");
				output.Append("function(");
				if (totalArgs != 0) {
					output.Append(JoinedTypelessBindingParams(0, totalArgs));
				}
				output.AppendLine(");");
				output.AppendLine("}");
				
				Console.WriteLine(output.ToString());
				output.Clear();
			}	 	
		}
		Console.WriteLine("}");
		Console.WriteLine("}");
	}
}
