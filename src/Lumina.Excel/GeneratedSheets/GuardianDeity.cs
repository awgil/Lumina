// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuardianDeity", columnHash: 0x30144b77 )]
    public partial class GuardianDeity : ExcelRow
    {
        
        public SeString Name { get; set; }
        public SeString Description { get; set; }
        public ushort Icon { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            Icon = parser.ReadColumn< ushort >( 2 );
        }
    }
}