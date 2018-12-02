using System;
using System.Collections.Generic;

namespace Entities
{
    public abstract class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public Clan Clan { get; set; }
        public List<string> Traits { get; set; }
        public string Body { get; set; }
        public string Illustrator { get; set; }
        public int CardNumber { get; set; }
        public SetName Set { get; set; }
        public bool IsUnique { get; set; }
        public bool OnRestrictedList { get; set; }
        public int AllowedCount { get; set; }
        public string Deck { get; set; }
    }
}