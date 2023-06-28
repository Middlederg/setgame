using System;

namespace Set.Web.Services;

public class PlayerModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "Player 1";
}
