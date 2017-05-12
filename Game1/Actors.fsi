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

val getBounds : WorldActor -> Rectangle 

val getDesiredBounds : WorldActor -> Vector2