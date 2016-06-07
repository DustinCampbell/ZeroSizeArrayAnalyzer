using System;
using System.Collections.Immutable;
using System.Composition;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.CodeAnalysis.Semantics;
using Microsoft.CodeAnalysis.Text;

namespace ZeroSizeArrayAnalyzer
{
    [ExportCodeFixProvider(LanguageNames.CSharp, LanguageNames.VisualBasic, Name = nameof(ZeroSizeArrayAnalyzerCodeFixProvider)), Shared]
    public class ZeroSizeArrayAnalyzerCodeFixProvider : CodeFixProvider
    {
        private const string title = "Use Array.Empty<T>";

        public sealed override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create(ZeroSizeArrayDiagnosticAnalyzer.DiagnosticId);

        // See https://github.com/dotnet/roslyn/blob/master/docs/analyzers/FixAllProvider.md for more information on Fix All Providers
        public sealed override FixAllProvider GetFixAllProvider() => WellKnownFixAllProviders.BatchFixer;

        public sealed override Task RegisterCodeFixesAsync(CodeFixContext context)
        {
            return Task.FromResult(false);
        }
    }
}