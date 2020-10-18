// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "InstanceContentGuide", columnHash: 0x5d58cc84 )]
    public class InstanceContentGuide : IExcelRow
    {
        
        public LazyRow< InstanceContent > Instance;
        public uint Unknown1;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Instance = new LazyRow< InstanceContent >( lumina, parser.ReadColumn< uint >( 0 ), language );
            Unknown1 = parser.ReadColumn< uint >( 1 );
        }
    }
}