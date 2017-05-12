module Actors

open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics
open Microsoft.Xna.Framework.Content

type BodyType = 
    | Static
    | Dynamic of Vector2

type PlayerState =
    | Nothing
    | Jumping
 
type ActorType =
    | Player of PlayerState
    | Obstacle
 
type WorldActor =
        ActorType *
        Vector2 *
        Vector2 *
        Texture2D option *
        BodyType

let getBounds ((_, p, s, _, _):WorldActor) : Rectangle =
    Rectangle(int p.X, int p.Y, int s.X, int s.Y)

let getDesiredBounds ((_, p, s, _, b):WorldActor) : Vector2 =
    match b with
    | Dynamic(s) -> p + s
    | _ -> p