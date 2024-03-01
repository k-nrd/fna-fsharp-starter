module Game

open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics

type FNAGame() as this =
    inherit Game()

    do this.Content.RootDirectory <- "Content"
    let graphics = new GraphicsDeviceManager(this)
    let mutable spriteBatch = Unchecked.defaultof<SpriteBatch>

    override this.Initialize() =
        spriteBatch <- new SpriteBatch(this.GraphicsDevice)
        base.Initialize()

    override this.LoadContent() = ()

    override this.Update(gameTime) = ()

    override this.Draw(gameTime) =
        this.GraphicsDevice.Clear Color.CornflowerBlue
        ()
