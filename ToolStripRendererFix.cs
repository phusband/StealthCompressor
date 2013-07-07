using System.Windows.Forms;

namespace Stealth_Compressor
{
    class ToolStripRendererFix : ToolStripSystemRenderer
    {
        public ToolStripRendererFix() { }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            //base.OnRenderToolStripBorder(e);
        }
    }
}
