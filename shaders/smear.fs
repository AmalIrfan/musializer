#version 330

// Input vertex attributes (from vertex shader)
in vec2 fragTexCoord;
in vec4 fragColor;

// Output fragment color
out vec4 finalColor;

void main()
{
    float r = 0.3;
    vec2 p = fragTexCoord - vec2(0.5);
    if (length(p) <= 0.5) {
        float s = length(p) - r;
        if (s <= 0) {
            finalColor = fragColor*1.5;
        } else {
            float t = 1 - s / (0.5 - r);
            finalColor = mix(vec4(fragColor.xyz, 0), fragColor*1.5, t*t*t);
        }
    } else {
        finalColor = vec4(0);
    }
}
