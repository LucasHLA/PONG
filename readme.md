# 🏓 Pong 2D - Unity Game

Um remake simples e funcional do clássico jogo Pong, desenvolvido com Unity 2D. O projeto é ideal para aprendizado de lógica de jogo, física, IA simples e gerenciamento de estados de jogo.

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
├── UI/
│   └── Canvas, Texts, Buttons
├── Prefabs/
├── Scenes/
│   └── Pong.unity
└── Audio/
    └── hit.wav, victory.wav
```

## 🧩 Como rodar

1. Clone o repositório
2. Abra com Unity Hub (versão 2022 ou superior)
3. Abra a cena `Pong.unity`
4. Aperte Play ▶️

## 📄 Licença

Uso educacional e livre para fins de aprendizado. Créditos para assets utilizados de terceiros (sons ou sprites, se aplicável).

## 💡 Autor

Desenvolvido por [Seu Nome Aqui]

---

> Este projeto é parte do meu portfólio como desenvolvedor de jogos e está disponível no GitHub. Sinta-se à vontade para enviar sugestões ou melhorias!

