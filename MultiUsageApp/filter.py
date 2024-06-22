from PIL import Image
import sys

def apply_filter(image_path, output_path, filter_name):
    image = Image.open(image_path).convert('RGB')
    r, g, b = image.split()

    if filter_name == "Красный":
        # Оставляем только красный канал
        filtered_image = Image.merge('RGB', (r, r.point(lambda i: 0), r.point(lambda i: 0)))
    elif filter_name == "Зеленый":
        # Оставляем только зеленый канал
        filtered_image = Image.merge('RGB', (g.point(lambda i: 0), g, g.point(lambda i: 0)))
    elif filter_name == "Синий":
        # Оставляем только синий канал
        filtered_image = Image.merge('RGB', (b.point(lambda i: 0), b.point(lambda i: 0), b))
    elif filter_name == "Черно-белое":
        # Преобразуем изображение в черно-белое
        filtered_image = image.convert('L').convert('RGB')
    elif filter_name == "Инверсия":
        # Применяем инверсию цветов
        filtered_image = Image.eval(image, lambda x: 255 - x)
    else:
        # Если фильтр не указан, не изменяем изображение
        filtered_image = image

    filtered_image.save(output_path)

if __name__ == "__main__":
    if len(sys.argv) != 4:
        print("Usage: python script.py filter_name input_image_path output_image_path")
    else:
        filter_name = sys.argv[1]
        input_path = sys.argv[2]
        output_path = sys.argv[3]
        apply_filter(input_path, output_path, filter_name)
