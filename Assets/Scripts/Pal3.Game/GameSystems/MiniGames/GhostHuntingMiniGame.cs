// ---------------------------------------------------------------------------------------------
//  Copyright (c) 2021-2023, Jiaqi Liu. All rights reserved.
//  See LICENSE file in the project root for license information.
// ---------------------------------------------------------------------------------------------

#if PAL3A

namespace Pal3.Game.GameSystems.MiniGames
{
    using System;
    using Command;
    using Core.Command;
    using Core.Command.SceCommands;

    public sealed class GhostHuntingMiniGame : IDisposable,
        ICommandExecutor<MiniGameStartGhostHuntingCommand>
    {
        public GhostHuntingMiniGame()
        {
            CommandExecutorRegistry<ICommand>.Instance.Register(this);
        }

        public void Dispose()
        {
            CommandExecutorRegistry<ICommand>.Instance.UnRegister(this);
        }

        public void Execute(MiniGameStartGhostHuntingCommand command)
        {
            CommandDispatcher<ICommand>.Instance.Dispatch(
                new UIDisplayNoteCommand("龙葵捉鬼小游戏暂未实现，现已跳过"));
        }
    }
}

#endif