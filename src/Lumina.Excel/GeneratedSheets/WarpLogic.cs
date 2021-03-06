// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WarpLogic", columnHash: 0x78e83215 )]
    public class WarpLogic : ExcelRow
    {
        public struct UnkStruct13Struct
        {
            public uint Argument;
        }
        
        public uint Unknown0 { get; set; }
        public SeString WarpName { get; set; }
        public bool CanSkipCutscene { get; set; }
        public SeString[] Function { get; set; }
        public UnkStruct13Struct[] UnkStruct13 { get; set; }
        public SeString Question { get; set; }
        public SeString ResponseYes { get; set; }
        public SeString ResponseNo { get; set; }
        
        public override void PopulateData( RowParser parser, GameData gameData, Language language )
        {
            base.PopulateData( parser, gameData, language );

            Unknown0 = parser.ReadColumn< uint >( 0 );
            WarpName = parser.ReadColumn< SeString >( 1 );
            CanSkipCutscene = parser.ReadColumn< bool >( 2 );
            Function = new SeString[ 10 ];
            for( var i = 0; i < 10; i++ )
                Function[ i ] = parser.ReadColumn< SeString >( 3 + i );
            UnkStruct13 = new UnkStruct13Struct[ 10 ];
            for( var i = 0; i < 10; i++ )
            {
                UnkStruct13[ i ] = new UnkStruct13Struct();
                UnkStruct13[ i ].Argument = parser.ReadColumn< uint >( 13 + ( i * 1 + 0 ) );
            }
            Question = parser.ReadColumn< SeString >( 23 );
            ResponseYes = parser.ReadColumn< SeString >( 24 );
            ResponseNo = parser.ReadColumn< SeString >( 25 );
        }
    }
}