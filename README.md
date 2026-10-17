# Wriggle.Physics

Optional source module containing the current Wriggle physics bodies, world solver, and area effects.

This first extraction intentionally preserves the game's existing contracts (`Wriggle.World.Terrain` and `Wriggle.Characters.Character`) so it can be added to the template without changing gameplay behavior. It is excluded from the base template build until those contracts are moved behind interfaces.

Include `Physics/**/*.cs` only in projects that provide those contracts and the Raylib-cs and ImGui.NET dependencies.
