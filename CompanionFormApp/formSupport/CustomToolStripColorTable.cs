
namespace CompanionFormApp.formSupport
{
    public class CustomToolStripColorTable : ProfessionalColorTable
    {
        public override Color MenuItemBorder => Color.LemonChiffon;

        public override Color MenuItemSelectedGradientBegin => Color.SaddleBrown;
        public override Color MenuItemSelectedGradientEnd => Color.SaddleBrown;
        
        public override Color MenuItemPressedGradientBegin => Color.LemonChiffon;
        public override Color MenuItemPressedGradientEnd => Color.LemonChiffon;
    }
}
