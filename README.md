# Wriggle.Physics

Optional physics module containing the current Wriggle physics bodies, world solver, destructible terrain, and area effects.

Terrain is part of this module under `Wriggle.World.Terrain`. Area effects do not depend on game characters: they apply physical effects and expose calculated damage for the host game to apply to its own actors.

Include `Physics/**/*.cs` in a project with the Raylib-cs and ImGui.NET dependencies. The module includes rendering hooks for the current Raylib game and can be split further later if a headless physics library is needed.
