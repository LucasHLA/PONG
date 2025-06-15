# 🏓 Pong 2D - Unity Game

Um clone simples e funcional do clássico jogo Pong, desenvolvido com Unity 2D.

## 🎮 Funcionalidades

- Movimento do jogador via teclado (W/S ou Setas)
- Inteligência artificial do oponente com margem de erro
- Bola com física e velocidade progressiva
- Detecção de colisão com raquetes e paredes
- Sistema de pontuação
- Tela de vitória com botão de reinício
- Sons de colisão e vitória
- UI com placar dinâmico

## 🛠 Tecnologias

- Unity 2022+
- C# Scripts
- TextMeshPro
- Physics 2D

## ▶️ Controles

| Ação             | Tecla             |
|------------------|------------------|
| Mover Jogador 1  | W / S            |
| Mover Jogador 2  | Controlado por IA|
| Reiniciar Jogo   | Botão na tela    |

## 🧠 Scripts principais

- `BallController.cs`: movimentação e colisão da bola
- `PlayerController.cs`: controle do jogador humano
- `AIController.cs`: controle da raquete automática
- `GameManager.cs`: pontuação, vitória, reinício
- `SoundManager.cs`: efeitos sonoros centralizados

## 📦 Estrutura sugerida

```
Assets/
├── Scripts/
│   ├── BallController.cs
│   ├── PlayerController.cs
│   ├── AIController.cs
│   ├── GameManager.cs
│   └── SoundManager.cs
├── Prefabs/
├── Scenes/
│   └── Main_Menu.unity
│   └── Game.unity
└── Audio/
    └── ping_pong_8bit_beeep.ogg, ping_pong_8bit_plop.ogg, Pong.mp3, victory.ogg
```

## 🧩 Como rodar

1. Clone o repositório
2. Abra com Unity Hub (versão 2022 ou superior)
3. Abra a cena `Main_Menu.unity`
4. Aperte Play ▶️

## 📄 Licença

Uso educacional e livre para fins de aprendizado.todos os efeitos sonoros e músicas foram utilizados do site https://opengameart.org.

## 💡 Autor

Desenvolvido por Lucas Henrique de Lima Antonio

---

