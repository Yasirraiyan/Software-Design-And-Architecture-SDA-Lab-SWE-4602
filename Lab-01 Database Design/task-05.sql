CREATE OR REPLACE PROCEDURE add_quest_rating(character_id INT, quest_id INT, rating_value INT)
LANGUAGE plpgsql
AS $$
BEGIN
    UPDATE quest_participation
    SET rating = rating_value,
        rating_timestamp = CURRENT_TIMESTAMP
    WHERE character_id = character_id AND quest_id = quest_id;

    CALL recalculate_quest_ratings();
END;