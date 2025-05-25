CREATE OR REPLACE FUNCTION get_quest_average_rating(questId INT)
RETURNS FLOAT
LANGUAGE plpgsql
AS $$
DECLARE
    avgRating FLOAT;
BEGIN
    SELECT average_rating INTO avgRating
    FROM quest
    WHERE id = questId;

    RETURN avgRating;
END;