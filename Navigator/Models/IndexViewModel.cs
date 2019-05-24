using EVEStandard.Models;

namespace Navigator.Models
{
    public class IndexViewModel
    {
        public readonly Icons PortraitsModel;
        public readonly CharacterInfo InfoModel;

        public IndexViewModel(Icons portraitsModel, CharacterInfo infoModel)
        {
            PortraitsModel = portraitsModel;
            InfoModel = infoModel;
        }
    }
}