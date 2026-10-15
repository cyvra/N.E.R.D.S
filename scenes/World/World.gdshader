
shader_type canvas_item;

uniform vec4 fog_color : source_color = vec4(0.48, 0.53, 0.62, 0.32);
uniform float fog_strength : hint_range(0.0, 1.0) = 0.32;
uniform float scale = 5.0;

void fragment() {
    vec2 p = UV * scale;
    float noise = fract(sin(dot(floor(p * 8.0),
        vec2(127.1, 311.7))) * 43758.5453);
    float mist = smoothstep(0.15, 0.9, noise);
    COLOR = vec4(fog_color.rgb, fog_color.a * mist * fog_strength);
}
