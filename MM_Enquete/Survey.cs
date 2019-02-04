using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM_Enquete
{
    partial class Survey: IStorable
    {
        private IDictionary<string, Option> option = new Dictionary<string, Option>();

        private Votes votes;

        public string Question { get; set; }

        /// contador votos enquete
       public int VoteCount
        {
            get
            {
                return votes.VoteCount;
            }
        }
        public Survey()
        {
            votes = new Votes(this);
        }

        public void SetOption(string id, string text)
        {
            Option option = new Option();
            option.Id = id.ToUpper();
            option.Text = text;

            if (!options.ConstainsKey(id))
            {
                options.Add(id);
            }
            else
            {
                options[id] = option;
            }
        }
    }
}
