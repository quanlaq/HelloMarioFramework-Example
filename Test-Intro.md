# Sample Level Submission – Hello Mario Framework

## Overview
This project is a custom level built using the **Hello Mario Framework** provided by the studio. The goal was to create a simple, functional platformer level and replace the default character with a new one, while maintaining compatibility with the framework's logic and systems.

---

## Key Features

### 1. Level Design
- Designed a **custom level** using **most of the built-in elements** from the Hello Mario Framework (e.g., coins, blocks, platforms, enemies).
- Integrated layout pieces and props from the [POLY STYLE – Platformer Starter Pack](https://assetstore.unity.com/packages/3d/environments/poly-style-platformer-starter-pack-256418) for a cohesive visual style.

### 2. Character Replacement
- Replaced the default Mario/Luigi characters with a character model from **Kenney's Mini Characters Pack**:  
  🔗 [https://kenney.nl/assets/mini-characters-1](https://kenney.nl/assets/mini-characters-1)
- Created a **custom Animator Controller** to replicate necessary movement animations (walk, jump, crouch, etc.) and connect it with the framework's animation triggers **without modifying the core framework**.
- Some animations were not available in the replacement model, so I skipped or approximated those where needed, while still maintaining full functionality of the gameplay.
- The solution was implemented without modifying the core framework, ensuring future compatibility and clean integration.

### 3. Visual Enhancements
- Implemented a stylized cartoon water effect using a free shader:  
  🔗 [Toon Water Shader by IronWarrior](https://github.com/IronWarrior/ToonWaterShader/tree/master)

### 4. Tools & Workflow
- Learned and utilized **RealtimeCSG** to assist in quick and efficient level layout construction with modular geometry.
- This helped speed up the blockout and testing process significantly.
- **However**, the level layout I created is **not visually impressive or polished** — it serves more as a functional prototype to demonstrate framework integration rather than final art or production-level design.

---

## Notes
- All core gameplay systems remain intact.
- Focused on keeping things **modular**, **non-invasive**, and **framework-compliant**.

---

## Dependencies
- [Kenney Mini Characters 1](https://kenney.nl/assets/mini-characters-1)
- [POLY STYLE Platformer Starter Pack](https://assetstore.unity.com/packages/3d/environments/poly-style-platformer-starter-pack-256418)
- [Toon Water Shader](https://github.com/IronWarrior/ToonWaterShader/tree/master)
- [RealtimeCSG](https://github.com/LogicalError/realtime-CSG-for-unity)

