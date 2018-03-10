namespace Miki.Common.Interfaces
{
	// TODO: Turn into DiscordEmote
    public class DiscordEmoji
    {
        public string Name { get; set; }
        public ulong? Id { get; set; }
        public string Url { get; set; }

		public override bool Equals(object obj)
		{
			return ToString() == obj.ToString();
		}

		public override string ToString()
		{
			if (Id != null)
			{
				return $"<:{Name}:{Id}>";
			}
			else
			{
				return Name;
			}
		}
	}
}