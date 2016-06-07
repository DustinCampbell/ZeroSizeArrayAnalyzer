using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace ZeroSizeArrayAnalyzer
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class ZeroSizeArrayDiagnosticAnalyzer : DiagnosticAnalyzer
    {
        #region Metadata
        public const string DiagnosticId = "ZeroSizeArrayAnalyzer";

        // You can change these strings in the Resources.resx file. If you do not want your analyzer to be localize-able, you can use regular strings for Title and MessageFormat.
        // See https://github.com/dotnet/roslyn/blob/master/docs/analyzers/Localizing%20Analyzers.md for more on localization
        private static readonly LocalizableString Title = new LocalizableResourceString(nameof(Resources.AnalyzerTitle), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString MessageFormat = new LocalizableResourceString(nameof(Resources.AnalyzerMessageFormat), Resources.ResourceManager, typeof(Resources));
        private static readonly LocalizableString Description = new LocalizableResourceString(nameof(Resources.AnalyzerDescription), Resources.ResourceManager, typeof(Resources));
        private const string Category = "Naming";

        // You can set the severity of your analyzer in your rule declaration
        private static DiagnosticDescriptor Rule = new DiagnosticDescriptor(DiagnosticId, Title, MessageFormat, Category, DiagnosticSeverity.Warning, isEnabledByDefault: true, description: Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(Rule);
        #endregion

        public override void Initialize(AnalysisContext context)
        {
            // This method is run the first time the analyzer is instantiated.
            // It lets the analyzer declare a callback that will be run in the
            // future when a particular event occurs during analysis, such as
            // the analyzer of a syntax node has occurred.


        }
    }
}
