﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class MovementComponent : Component
    {
        private float movementSpeed = 1;

        public MovementComponent(Actor parentActor) : base(parentActor)
        {
        }

        public override void OnDestroy() { }

        public override void Start()
        {
            EventManager.Subscribe<OnKeyPressedEvent>(onKeyPressed);
        }

        private void onKeyPressed(EventContext context)
        {
            var specificContext = context as OnKeyPressedEventContext;

            if (specificContext.PressedKey == ConsoleKey.LeftArrow)
            {
                this.ParentActor.Position.x -= (int)movementSpeed;
            }

            if (specificContext.PressedKey == ConsoleKey.RightArrow)
            {
                this.ParentActor.Position.x += (int)movementSpeed;
            }

            if (specificContext.PressedKey == ConsoleKey.UpArrow)
            {
                this.ParentActor.Position.y -= (int)movementSpeed;
            }

            if (specificContext.PressedKey == ConsoleKey.DownArrow)
            {
                this.ParentActor.Position.y += (int)movementSpeed;
            }
        }

        public override void Update(float deltaTime) { }
    }
}
