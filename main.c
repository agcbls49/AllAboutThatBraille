#include <stdio.h>
#include "raylib.h"

int main(void) {
    const int screenWidth = 1200;
    const int screenHeight = 800;

    InitWindow(screenWidth, screenHeight, "AllAboutThatBraille");

    const char introductionText[] = "AllAboutThatBraille - familiarize yourself with basic Braille!.";

    // Load the Custom Font
    Font font = LoadFont("../nexa/Nexa-Heavy.ttf");
    Vector2 position = {50, 50};

    if (font.texture.id == 0) {
        printf("Font failed to load!\n");
    }

    while (!WindowShouldClose()) {
        BeginDrawing();
            ClearBackground(BLACK);
            DrawTextEx(font, introductionText, position, 30, 2, WHITE);

            // Box for braille
            DrawRectangle(49, 110, 600, 600, WHITE);

            // Box for braille letter or other characters
            DrawRectangle(692, 110, 450, 550, BLUE);

            // Test Skill Button
            DrawRectangle(692, 630, 450, 80, YELLOW);


            // See X and Y coordinates
            DrawText(TextFormat("Mouse: %d, %d", GetMouseX(), GetMouseY()),10, 10, 20, WHITE);

        EndDrawing();
    }

    CloseWindow();

    return 0;
}
